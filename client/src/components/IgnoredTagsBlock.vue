<template>
  <content-block class="ignored-tags-block">
    <template #head>
      <div class="head">
        <span>Ignored Tags</span>
         <button v-if="ignoredTags.length > 0 && !isChangeMode" class="btn" @click.stop="setChangeMode">Change</button>
      </div>
    </template>
    <template #body>
      <div class="body">
        <primary-button
          class="add-btn"
          v-if="ignoredTags.length === 0 && !isChangeMode"
          @click.stop="setChangeMode"
        >
          <template #label> Add tag to ignored </template>
        </primary-button>
        <div v-else class="input">
          <div class="tags">
            <tag
              :allow-remove="true"
              class="tags__tag"
              v-for="(tag, idx) in ignoredTags"
              :key="idx"
              :tag="tag"
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
import PrimaryButton from "@/components/PrimaryButton";
import AddInput from "@/components/AddInput";
import Tag from "@/components/Tag";
export default {
  name: "IgnoredTagsBlock",
  components: {
    ContentBlock,
    PrimaryButton,
    AddInput,
    Tag,
  },
};
</script>

<script setup>
import { ref, onMounted, onUnmounted } from "vue";

const isChangeMode = ref(false);
const ignoredTags = ref([]);
const setChangeMode = () => {
  isChangeMode.value = true;
};
const stopChange = ({ target }) => {
  if (!target.closest(".ignored-tags-block")) {
    isChangeMode.value = false;
  }
};
const handleAddTag = (_tag) => {
  ignoredTags.value.push(_tag);
};
const handleRemove = (_tag) => {
  ignoredTags.value = ignoredTags.value.filter((_el) => _el !== _tag);
};
onMounted(() => {
  document.addEventListener("click", stopChange);
});
onUnmounted(() => {
  document.removeEventListener("click", stopChange);
});
</script>

<style scoped lang="scss">
.body {
  display: flex;
  width: 100%;
}
.tags {
  display: flex;
  flex-wrap: wrap;
  margin-bottom: 1rem;
  &__tag {
    margin-right: 3px;
  }
}
.btn {
  background: transparent;
  border: none;
  color: var(--black900);
  cursor: pointer;
  font-size: 14px;
}
.head {
  display: flex;
  justify-content: space-between;
}
.add-btn {
  margin: 0 auto;
}
.input {
  width: 100%;
}
</style>
