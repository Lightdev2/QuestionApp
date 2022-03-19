<template>
  <content-block class="following-tags-block">
    <template #head>
      <div class="head">
        <span>Followed tags</span>
        <button v-if="followedTags.length > 0" class="btn" @click="setChangeMode">Change</button>
      </div>
    </template>
    <template #body>
      <div class="body" v-if="!followedTags.length > 0 && !isChangeMode">
        <spot-search class="search" />
        <p class="text">
          Keep track of the tags so that the questions you are interested in are
          in the spotlight.
        </p>
        <primary-button @click.stop="setChangeMode">
          <template #label>
            <div class="label"><eye class="icon" />Add Tag to Followed</div>
          </template>
        </primary-button>
      </div>
      <div v-else>
        <div>
          <div class="tags">
            <tag
              :allow-remove="true"
              class="tags__tag"
              :tag="tag"
              v-for="(tag, idx) in followedTags"
              :key="idx"
              @remove="handleRemove"
            />
          </div>
          <add-input v-if="isChangeMode" @addTag="handleAddTag" />
        </div>
      </div>
    </template>
  </content-block>
</template>

<script>
import ContentBlock from "@/components/ContentBlock";
import SpotSearch from "@/assets/spot-search";
import PrimaryButton from "@/components/PrimaryButton";
import AddInput from "@/components/AddInput";
import Eye from "@/assets/eye";
import Tag from "@/components/Tag";
export default {
  name: "FollowingTagsBlock",
  components: {
    ContentBlock,
    SpotSearch,
    PrimaryButton,
    Eye,
    AddInput,
    Tag,
  },
};
</script>

<script setup>
import { ref, onMounted, onUnmounted } from "vue";
const isChangeMode = ref(false);
const followedTags = ref([]);
const setChangeMode = () => {
  isChangeMode.value = true;
};
const stopChange = ({ target }) => {
  if (!target.closest(".following-tags-block")) {
    isChangeMode.value = false;
  }
};
const handleAddTag = (_tag) => {
  followedTags.value.push(_tag);
};
const handleRemove = (_tag) => {
  followedTags.value = followedTags.value.filter(_el => _el !== _tag);
};
onMounted(() => {
  document.addEventListener("click", stopChange);
});
onUnmounted(() => {
  document.removeEventListener("click", stopChange);
});
</script>

<style scoped lang="scss">
.label {
  display: flex;
  align-items: center;
}
.icon {
  margin-right: 3px;
  fill: var(--powder700);
}
.body {
  display: flex;
  flex-direction: column;
  align-items: center;
}
.text {
  text-align: center;
  color: var(--black300);
}
.search {
  fill: var(--blue700);
}
.head {
  display: flex;
  justify-content: space-between;
  color: var(--black900);
}
.btn {
  background: transparent;
  border: none;
  color: var(--black900);
  cursor: pointer;
  font-size: 14px;
}
.tags {
  display: flex;
  margin-bottom: 1rem;
  &__tag {
    margin-right: 3px;
  }
}
</style>
