<template>
  <div class="tag-block">
    <tag :tag="props.tag.title"/>
    <p class="tag-block__info">
      {{props.tag.info}}
    </p>
    <div class="tag-block__footer">
      {{props.tag.count}}
    </div>
  </div>
</template>

<script>
import Tag from "@/components/Tag"

export default {
  name: "TagBlock",
  components: {
    Tag
  }
}
</script>

<script setup>
import {defineProps} from "vue";

const props = defineProps(['tag'])
</script>

<style scoped lang="scss">
.tag-block {
  border: 1px solid var(--black100);
  padding: 12px;
  border-radius: 5px;
  display: flex;
  flex-direction: column;
  width: 250px;
  flex-grow: 1;
  &__info {
    line-clamp: 4;
    overflow: hidden;
    color: var(--black700);
    font-size: 14px;
  }
  &__footer {
    color: var(--black400);
  }
}
</style>