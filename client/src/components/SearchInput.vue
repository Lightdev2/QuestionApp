<template>
  <div class="input">
    <input class="input__inp" type="text" :placeholder="placeholder" />
    <search class="input__icon" />
  </div>
</template>

<script>
import Search from "@/assets/search";
export default {
  name: "SearchInput",
  components: {
    Search,
  },
  props: {
    placeholder: {
      required: false,
      default: ""
    }
  }
};
</script>

<style scoped lang="scss">
.input {
  position: relative;
  border: 1px solid var(--black200);
  border-radius: 5px;
  &__icon {
    position: absolute;
    width: 20px;
    height: 20px;
    top: 50%;
    transform: translateY(-50%);
    left: 5px;
    fill: var(--black200);
  }
  &__inp {
    background: var(--black);
    border: none;
    width: 100%;
    height: 100%;
    border-radius: 5px;
    padding-left: 35px;
    outline: none;
    color: var(--black200);
  }
}
</style>
